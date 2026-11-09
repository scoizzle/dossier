# Fact 67851f51

Store id: 87999c39-c497-4f3b-a044-9485bfce9ad0

## Text

```text
def contribute_to_class(self, cls, name, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.7374570+00:00`

## Data

```json
{
  "end_line": 2925,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2918,
  "symbol": "AutoFieldMixin.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2918,"selector":"L2918-L2925","symbol":"AutoFieldMixin.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2925,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2918,
    "symbol": "AutoFieldMixin.contribute_to_class"
  },
  "id": "87999c39-c497-4f3b-a044-9485bfce9ad0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7374570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2918,
        "selector": "L2918-L2925",
        "symbol": "AutoFieldMixin.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "35c23b4d-6cac-470b-ab9c-738bb12fcbd6",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, **kwargs)"
}
```
