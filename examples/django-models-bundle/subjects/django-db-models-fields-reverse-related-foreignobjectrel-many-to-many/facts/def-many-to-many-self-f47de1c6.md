# Fact f47de1c6

Store id: 1c8cbae1-7b0d-4387-99cb-64ad955032ba

## Text

```text
def many_to_many(self)
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
- posted_at: `2026-11-09T23:32:00.2325960+00:00`

## Data

```json
{
  "end_line": 101,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 99,
  "symbol": "ForeignObjectRel.many_to_many"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":99,"selector":"L99-L101","symbol":"ForeignObjectRel.many_to_many"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.many_to_many](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 101,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 99,
    "symbol": "ForeignObjectRel.many_to_many"
  },
  "id": "1c8cbae1-7b0d-4387-99cb-64ad955032ba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2325960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 99,
        "selector": "L99-L101",
        "symbol": "ForeignObjectRel.many_to_many"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "cf452209-a7ec-49a9-bc4e-71545deacee6",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.many_to_many",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def many_to_many(self)"
}
```
