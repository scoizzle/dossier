# Fact f0fd4988

Store id: 176df77d-ee24-4945-9dd0-27f971d54a97

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:03.1626140+00:00`

## Data

```json
{
  "end_line": 139,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 117,
  "symbol": "Lookup.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L139","symbol":"Lookup.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 139,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 117,
    "symbol": "Lookup.process_rhs"
  },
  "id": "176df77d-ee24-4945-9dd0-27f971d54a97",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1626140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L139",
        "symbol": "Lookup.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "08ad1001-f48b-4410-bd3f-413a355c0e44",
  "subject_name": "django/db/models/lookups::Lookup.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
