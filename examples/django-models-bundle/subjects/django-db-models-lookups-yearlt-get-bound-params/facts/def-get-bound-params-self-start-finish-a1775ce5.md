# Fact a1775ce5

Store id: cf32fd5d-bf9d-44d0-8229-06f2bfef6868

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
- posted_at: `2026-11-09T23:32:03.4550470+00:00`

## Data

```json
{
  "end_line": 773,
  "entity_kind": "method",
  "parent": "YearLt",
  "start_line": 772,
  "symbol": "YearLt.get_bound_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":772,"selector":"L772-L773","symbol":"YearLt.get_bound_params"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLt.get_bound_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 773,
    "entity_kind": "method",
    "parent": "YearLt",
    "start_line": 772,
    "symbol": "YearLt.get_bound_params"
  },
  "id": "cf32fd5d-bf9d-44d0-8229-06f2bfef6868",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4550470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 772,
        "selector": "L772-L773",
        "symbol": "YearLt.get_bound_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "7292bf00-f450-4a44-af24-36515564956f",
  "subject_name": "django/db/models/lookups::YearLt.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
