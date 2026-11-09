# Fact bb26a20d

Store id: ceee3c9c-2ff5-49e0-9c3b-f53ea77999c0

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
- posted_at: `2026-11-09T23:44:55.0838300+00:00`

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
  "id": "ceee3c9c-2ff5-49e0-9c3b-f53ea77999c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0838300+00:00"
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
  "subject_id": "dcdff3cc-9380-4407-b23b-ddf2f879bbf9",
  "subject_name": "django/db/models/lookups::YearGte.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
