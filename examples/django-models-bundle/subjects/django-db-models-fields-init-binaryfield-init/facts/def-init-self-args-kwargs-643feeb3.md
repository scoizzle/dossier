# Fact 643feeb3

Store id: e9db5ec9-4f87-477c-a968-cb41fc84b9a0

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
- posted_at: `2026-11-09T22:39:42.6879740+00:00`

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
  "id": "e9db5ec9-4f87-477c-a968-cb41fc84b9a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6879740+00:00"
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
  "subject_id": "d1a322d3-494c-4565-884a-6102690b7534",
  "subject_name": "django/db/models/fields/__init__::BinaryField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
