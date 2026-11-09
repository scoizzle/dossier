# Fact db797e0b

Store id: 0046c8dc-29d9-4ba2-be29-98df5d2ca9cf

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
- posted_at: `2026-11-09T22:39:42.7491970+00:00`

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
  "id": "0046c8dc-29d9-4ba2-be29-98df5d2ca9cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7491970+00:00"
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
  "subject_id": "af2ca235-1b7c-4ac4-8fd8-5cccce3652ad",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMeta.__subclasscheck__",
  "tags": [
    "entity:method"
  ],
  "text": "def __subclasscheck__(self, subclass)"
}
```
