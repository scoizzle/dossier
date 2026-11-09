# Fact 25c11b91

Store id: dec82303-da05-4907-a281-2a862c663ecf

## Text

```text
def get_prep_lhs(self)
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
- posted_at: `2026-11-09T22:39:45.5799060+00:00`

## Data

```json
{
  "end_line": 99,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 96,
  "symbol": "TupleLookupMixin.get_prep_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":96,"selector":"L96-L99","symbol":"TupleLookupMixin.get_prep_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.get_prep_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 99,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 96,
    "symbol": "TupleLookupMixin.get_prep_lhs"
  },
  "id": "dec82303-da05-4907-a281-2a862c663ecf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5799060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 96,
        "selector": "L96-L99",
        "symbol": "TupleLookupMixin.get_prep_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "7a63b40d-fb25-4d95-a663-c8eadeac67a2",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_prep_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lhs(self)"
}
```
