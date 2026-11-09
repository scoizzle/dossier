# Fact 32cc8fc9

Store id: 551de44f-5c02-497c-b6fa-c579119dc68f

## Text

```text
def get_prep_lookup(self)
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
- posted_at: `2026-11-09T22:39:47.9914860+00:00`

## Data

```json
{
  "end_line": 97,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 89,
  "symbol": "Lookup.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":89,"selector":"L89-L97","symbol":"Lookup.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 97,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 89,
    "symbol": "Lookup.get_prep_lookup"
  },
  "id": "551de44f-5c02-497c-b6fa-c579119dc68f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.9914860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 89,
        "selector": "L89-L97",
        "symbol": "Lookup.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "07429ad1-085a-4861-9da4-e30f8403d598",
  "subject_name": "django/db/models/lookups::Lookup.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
