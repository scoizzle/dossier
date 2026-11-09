# Fact a1775ce5

Store id: 37227f5f-3606-49df-bec9-d586ca64d49f

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
- posted_at: `2026-11-09T22:39:48.2606010+00:00`

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
  "id": "37227f5f-3606-49df-bec9-d586ca64d49f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2606010+00:00"
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
  "subject_id": "db764085-db33-484b-8924-34860a3c0919",
  "subject_name": "django/db/models/lookups::YearLt.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
