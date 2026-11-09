# Fact 3c8134f6

Store id: 866ef344-1d1a-4efc-84fb-e971496876d8

## Text

```text
def related_model(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.4320600+00:00`

## Data

```json
{
  "end_line": 97,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 90,
  "symbol": "ForeignObjectRel.related_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":90,"selector":"L90-L97","symbol":"ForeignObjectRel.related_model"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.related_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 97,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 90,
    "symbol": "ForeignObjectRel.related_model"
  },
  "id": "866ef344-1d1a-4efc-84fb-e971496876d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4320600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 90,
        "selector": "L90-L97",
        "symbol": "ForeignObjectRel.related_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "e97549ee-7976-40e4-bf1d-6476ea6935db",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.related_model",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_model(self)"
}
```
