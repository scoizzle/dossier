# Fact e47cbbae

Store id: a4e71a6d-84ef-442a-af05-afe39db5a80d

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
- posted_at: `2026-11-09T23:44:50.3126850+00:00`

## Data

```json
{
  "end_line": 2879,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2877,
  "symbol": "AutoFieldMixin.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2877,"selector":"L2877-L2879","symbol":"AutoFieldMixin.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2879,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2877,
    "symbol": "AutoFieldMixin.__init__"
  },
  "id": "a4e71a6d-84ef-442a-af05-afe39db5a80d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3126850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2877,
        "selector": "L2877-L2879",
        "symbol": "AutoFieldMixin.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0a4001e6-9e7a-4aef-bb8a-3cf7f792a351",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
