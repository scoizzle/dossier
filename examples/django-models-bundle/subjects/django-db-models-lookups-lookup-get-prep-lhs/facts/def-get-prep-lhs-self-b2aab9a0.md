# Fact b2aab9a0

Store id: 1bd5e86a-04af-4c90-9bb5-3f75a82b2d86

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
- posted_at: `2026-11-09T23:44:54.8632960+00:00`

## Data

```json
{
  "end_line": 102,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 99,
  "symbol": "Lookup.get_prep_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":99,"selector":"L99-L102","symbol":"Lookup.get_prep_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.get_prep_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 102,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 99,
    "symbol": "Lookup.get_prep_lhs"
  },
  "id": "1bd5e86a-04af-4c90-9bb5-3f75a82b2d86",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8632960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 99,
        "selector": "L99-L102",
        "symbol": "Lookup.get_prep_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "1707d9db-3890-4d36-be3f-032fadb17237",
  "subject_name": "django/db/models/lookups::Lookup.get_prep_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lhs(self)"
}
```
