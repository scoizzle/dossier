# Fact 67851f51

Store id: c96ebc86-1b86-40ce-a8c3-30fd5dea4356

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
- posted_at: `2026-11-09T23:44:50.3247110+00:00`

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
  "id": "c96ebc86-1b86-40ce-a8c3-30fd5dea4356",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3247110+00:00"
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
  "subject_id": "4191b710-09d9-46ca-816b-ddf9becba110",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, **kwargs)"
}
```
