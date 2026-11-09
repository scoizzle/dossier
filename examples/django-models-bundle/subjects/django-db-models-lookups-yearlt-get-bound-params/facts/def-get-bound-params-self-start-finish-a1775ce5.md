# Fact a1775ce5

Store id: 311dec5e-2eb7-474b-8018-e205ee193f7c

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
- posted_at: `2026-11-09T23:44:55.0900430+00:00`

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
  "id": "311dec5e-2eb7-474b-8018-e205ee193f7c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0900430+00:00"
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
  "subject_id": "020351a3-e687-4ccb-bd2a-237773cf7f21",
  "subject_name": "django/db/models/lookups::YearLt.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
