# Fact 643feeb3

Store id: 5cb71cb5-900a-4df3-9a2c-fa764beee2a0

## Text

```text
def __init__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.2766800+00:00`

## Data

```json
{
  "end_line": 2755,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2751,
  "symbol": "BinaryField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2751,"selector":"L2751-L2755","symbol":"BinaryField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2755,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2751,
    "symbol": "BinaryField.__init__"
  },
  "id": "5cb71cb5-900a-4df3-9a2c-fa764beee2a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2766800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2751,
        "selector": "L2751-L2755",
        "symbol": "BinaryField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a6c643a6-6ba6-4341-bc62-669abea41d1f",
  "subject_name": "django/db/models/fields/__init__::BinaryField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
