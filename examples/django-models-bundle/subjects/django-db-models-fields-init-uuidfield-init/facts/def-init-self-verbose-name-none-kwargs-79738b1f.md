# Fact 79738b1f

Store id: 5905b072-600a-4164-9ef5-de5644076921

## Text

```text
def __init__(self, verbose_name=None, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.2963950+00:00`

## Data

```json
{
  "end_line": 2828,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2826,
  "symbol": "UUIDField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2826,"selector":"L2826-L2828","symbol":"UUIDField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2828,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2826,
    "symbol": "UUIDField.__init__"
  },
  "id": "5905b072-600a-4164-9ef5-de5644076921",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2963950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2826,
        "selector": "L2826-L2828",
        "symbol": "UUIDField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6579deab-43e8-4777-afe3-d65e7c4aff5a",
  "subject_name": "django/db/models/fields/__init__::UUIDField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, verbose_name=None, **kwargs)"
}
```
