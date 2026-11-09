# Fact bb26a20d

Store id: 78f36cc3-356e-495d-a996-cc2e293b5e8b

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
- posted_at: `2026-11-09T23:32:03.4485610+00:00`

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
  "id": "78f36cc3-356e-495d-a996-cc2e293b5e8b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4485610+00:00"
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
  "subject_id": "d8faf9f6-0e9a-498a-b5e0-4156f6dc767c",
  "subject_name": "django/db/models/lookups::YearGte.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
