# Fact bb26a20d

Store id: 7512056b-7fc0-4dc7-8027-9cb9aabd8380

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
- posted_at: `2026-11-09T22:39:48.2534880+00:00`

## Data

```json
{
  "end_line": 768,
  "entity_kind": "method",
  "parent": "YearGte",
  "start_line": 767,
  "symbol": "YearGte.get_bound_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":767,"selector":"L767-L768","symbol":"YearGte.get_bound_params"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearGte.get_bound_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 768,
    "entity_kind": "method",
    "parent": "YearGte",
    "start_line": 767,
    "symbol": "YearGte.get_bound_params"
  },
  "id": "7512056b-7fc0-4dc7-8027-9cb9aabd8380",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2534880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 767,
        "selector": "L767-L768",
        "symbol": "YearGte.get_bound_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "deea33e3-478a-41c6-bc15-084bc96fa15b",
  "subject_name": "django/db/models/lookups::YearGte.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
