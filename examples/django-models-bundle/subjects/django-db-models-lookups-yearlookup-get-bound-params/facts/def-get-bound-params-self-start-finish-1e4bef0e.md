# Fact 1e4bef0e

Store id: b0a05fab-2ef5-422e-bbd7-0b25ade8db15

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
- posted_at: `2026-11-09T23:44:55.0634290+00:00`

## Data

```json
{
  "end_line": 750,
  "entity_kind": "method",
  "parent": "YearLookup",
  "start_line": 747,
  "symbol": "YearLookup.get_bound_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":747,"selector":"L747-L750","symbol":"YearLookup.get_bound_params"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLookup.get_bound_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 750,
    "entity_kind": "method",
    "parent": "YearLookup",
    "start_line": 747,
    "symbol": "YearLookup.get_bound_params"
  },
  "id": "b0a05fab-2ef5-422e-bbd7-0b25ade8db15",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0634290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 747,
        "selector": "L747-L750",
        "symbol": "YearLookup.get_bound_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "4b2f7e8f-26e1-42fe-a48c-5b2f6661eef8",
  "subject_name": "django/db/models/lookups::YearLookup.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
