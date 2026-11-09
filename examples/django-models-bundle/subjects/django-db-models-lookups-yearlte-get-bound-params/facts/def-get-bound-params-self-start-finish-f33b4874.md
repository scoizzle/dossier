# Fact f33b4874

Store id: b9339303-def6-4855-831a-a5331d14940f

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
- posted_at: `2026-11-09T23:44:55.0966030+00:00`

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
  "id": "b9339303-def6-4855-831a-a5331d14940f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0966030+00:00"
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
  "subject_id": "3536569c-0b6e-46e9-8598-fc26ea77eeab",
  "subject_name": "django/db/models/lookups::YearLte.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
