# Fact 6a4c01c2

Store id: ce5ad654-aaf9-472f-9ed8-991b1376eaad

## Text

```text
def get_db_prep_lookup(self, value, connection)
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
- posted_at: `2026-11-09T23:44:54.8737280+00:00`

## Data

```json
{
  "end_line": 105,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 104,
  "symbol": "Lookup.get_db_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":104,"selector":"L104-L105","symbol":"Lookup.get_db_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.get_db_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 105,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 104,
    "symbol": "Lookup.get_db_prep_lookup"
  },
  "id": "ce5ad654-aaf9-472f-9ed8-991b1376eaad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8737280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 104,
        "selector": "L104-L105",
        "symbol": "Lookup.get_db_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a1c47f3c-8e59-41bd-96c4-5fc067ff4164",
  "subject_name": "django/db/models/lookups::Lookup.get_db_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_lookup(self, value, connection)"
}
```
