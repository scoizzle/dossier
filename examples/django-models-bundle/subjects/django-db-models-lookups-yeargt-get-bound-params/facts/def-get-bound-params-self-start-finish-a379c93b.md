# Fact a379c93b

Store id: bacf9188-07f8-4ab5-8653-d4c882700bb9

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
- posted_at: `2026-11-09T22:39:48.2475780+00:00`

## Data

```json
{
  "end_line": 763,
  "entity_kind": "method",
  "parent": "YearGt",
  "start_line": 762,
  "symbol": "YearGt.get_bound_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":762,"selector":"L762-L763","symbol":"YearGt.get_bound_params"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearGt.get_bound_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 763,
    "entity_kind": "method",
    "parent": "YearGt",
    "start_line": 762,
    "symbol": "YearGt.get_bound_params"
  },
  "id": "bacf9188-07f8-4ab5-8653-d4c882700bb9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2475780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 762,
        "selector": "L762-L763",
        "symbol": "YearGt.get_bound_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a6ea2340-d204-47c6-a579-b2a8284fa741",
  "subject_name": "django/db/models/lookups::YearGt.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
