# Fact 62d39fde

Store id: a6f38045-dd15-4065-b2d2-cefa972cf600

## Text

```text
def get_lookups(self)
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
- posted_at: `2026-11-09T23:44:52.4588020+00:00`

## Data

```json
{
  "end_line": 119,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 118,
  "symbol": "ForeignObjectRel.get_lookups"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":118,"selector":"L118-L119","symbol":"ForeignObjectRel.get_lookups"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 119,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 118,
    "symbol": "ForeignObjectRel.get_lookups"
  },
  "id": "a6f38045-dd15-4065-b2d2-cefa972cf600",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4588020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 118,
        "selector": "L118-L119",
        "symbol": "ForeignObjectRel.get_lookups"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "4bf37935-4657-4252-8464-88f40e8fd235",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_lookups",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lookups(self)"
}
```
