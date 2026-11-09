# Fact db797e0b

Store id: f6f77032-f3c9-40d6-a54b-fa0ef5d403b0

## Text

```text
def __subclasscheck__(self, subclass)
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
- posted_at: `2026-11-09T23:31:56.9171140+00:00`

## Data

```json
{
  "end_line": 2960,
  "entity_kind": "method",
  "parent": "AutoFieldMeta",
  "start_line": 2957,
  "symbol": "AutoFieldMeta.__subclasscheck__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2957,"selector":"L2957-L2960","symbol":"AutoFieldMeta.__subclasscheck__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMeta.__subclasscheck__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2960,
    "entity_kind": "method",
    "parent": "AutoFieldMeta",
    "start_line": 2957,
    "symbol": "AutoFieldMeta.__subclasscheck__"
  },
  "id": "f6f77032-f3c9-40d6-a54b-fa0ef5d403b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9171140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2957,
        "selector": "L2957-L2960",
        "symbol": "AutoFieldMeta.__subclasscheck__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "cb6b27e9-c7ea-44ad-96f1-1b3fadd955b8",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMeta.__subclasscheck__",
  "tags": [
    "entity:method"
  ],
  "text": "def __subclasscheck__(self, subclass)"
}
```
