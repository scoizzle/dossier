# Fact f33b4874

Store id: 4458df63-e897-412b-bee4-69f93bc3b009

## Text

```text
def get_bound_params(self, start, finish)
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
- posted_at: `2026-11-09T22:39:48.2686570+00:00`

## Data

```json
{
  "end_line": 778,
  "entity_kind": "method",
  "parent": "YearLte",
  "start_line": 777,
  "symbol": "YearLte.get_bound_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":777,"selector":"L777-L778","symbol":"YearLte.get_bound_params"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLte.get_bound_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 778,
    "entity_kind": "method",
    "parent": "YearLte",
    "start_line": 777,
    "symbol": "YearLte.get_bound_params"
  },
  "id": "4458df63-e897-412b-bee4-69f93bc3b009",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2686570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 777,
        "selector": "L777-L778",
        "symbol": "YearLte.get_bound_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e3b9531c-d332-4c0d-b0af-0b5d9563dc26",
  "subject_name": "django/db/models/lookups::YearLte.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
