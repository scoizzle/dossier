# Fact 4bd8d6af

Store id: b0564a47-b62c-429d-8ddb-9f716ef2868c

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )
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
- posted_at: `2026-11-09T23:44:54.9045570+00:00`

## Data

```json
{
  "end_line": 196,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 184,
  "symbol": "Lookup.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":184,"selector":"L184-L196","symbol":"Lookup.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 196,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 184,
    "symbol": "Lookup.resolve_expression"
  },
  "id": "b0564a47-b62c-429d-8ddb-9f716ef2868c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9045570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 184,
        "selector": "L184-L196",
        "symbol": "Lookup.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "aeceac05-bdb8-4e2e-8cfe-dcb1590d1055",
  "subject_name": "django/db/models/lookups::Lookup.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
