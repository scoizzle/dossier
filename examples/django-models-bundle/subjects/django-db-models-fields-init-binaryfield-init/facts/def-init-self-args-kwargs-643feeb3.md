# Fact 643feeb3

Store id: 9d7e3e2c-5ecf-4cbf-a580-da0c6cf53840

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
- posted_at: `2026-11-09T23:31:56.8418770+00:00`

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
  "id": "9d7e3e2c-5ecf-4cbf-a580-da0c6cf53840",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8418770+00:00"
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
  "subject_id": "567500a5-9272-4cd9-93af-7529d01792aa",
  "subject_name": "django/db/models/fields/__init__::BinaryField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
