# Fact 51ba8dec

Store id: 18eb0f2c-22e5-4077-ac1d-42fe21c4e672

## Text

```text
def accessor_name(self)
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
- posted_at: `2026-11-09T23:32:00.3034740+00:00`

## Data

```json
{
  "end_line": 212,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 210,
  "symbol": "ForeignObjectRel.accessor_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":210,"selector":"L210-L212","symbol":"ForeignObjectRel.accessor_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.accessor_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 212,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 210,
    "symbol": "ForeignObjectRel.accessor_name"
  },
  "id": "18eb0f2c-22e5-4077-ac1d-42fe21c4e672",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3034740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 210,
        "selector": "L210-L212",
        "symbol": "ForeignObjectRel.accessor_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "051af4f9-78a9-494a-8d7a-5ae2a282d387",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.accessor_name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def accessor_name(self)"
}
```
