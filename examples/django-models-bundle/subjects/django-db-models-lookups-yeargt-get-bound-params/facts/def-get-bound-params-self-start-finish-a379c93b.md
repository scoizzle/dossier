# Fact a379c93b

Store id: 902c2ce2-e087-4d28-b10f-6a0f04a509b9

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
- posted_at: `2026-11-09T23:44:55.0779090+00:00`

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
  "id": "902c2ce2-e087-4d28-b10f-6a0f04a509b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0779090+00:00"
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
  "subject_id": "c46a8bc1-0823-498e-94f4-e120e3e5e41d",
  "subject_name": "django/db/models/lookups::YearGt.get_bound_params",
  "tags": [
    "entity:method"
  ],
  "text": "def get_bound_params(self, start, finish)"
}
```
