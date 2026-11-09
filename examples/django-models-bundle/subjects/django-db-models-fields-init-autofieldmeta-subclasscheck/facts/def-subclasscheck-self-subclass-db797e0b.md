# Fact db797e0b

Store id: b2ff1807-0e22-4018-9a27-dde3ddd25085

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
- posted_at: `2026-11-09T23:44:50.3326940+00:00`

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
  "id": "b2ff1807-0e22-4018-9a27-dde3ddd25085",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3326940+00:00"
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
  "subject_id": "a89c65b4-e557-4683-9cfc-b9ffde02cd43",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMeta.__subclasscheck__",
  "tags": [
    "entity:method"
  ],
  "text": "def __subclasscheck__(self, subclass)"
}
```
