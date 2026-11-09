# Fact b5d4f81e

Store id: 875a8a65-d05b-4bb6-843a-e1b89a5dd525

## Text

```text
def _process_as_oracle(self, sql, params, connection, key_transforms=None)
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
- posted_at: `2026-11-09T22:39:43.6882860+00:00`

## Data

```json
{
  "end_line": 386,
  "entity_kind": "method",
  "parent": "ProcessJSONLHSMixin",
  "start_line": 363,
  "symbol": "ProcessJSONLHSMixin._process_as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":363,"selector":"L363-L386","symbol":"ProcessJSONLHSMixin._process_as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::ProcessJSONLHSMixin._process_as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 386,
    "entity_kind": "method",
    "parent": "ProcessJSONLHSMixin",
    "start_line": 363,
    "symbol": "ProcessJSONLHSMixin._process_as_oracle"
  },
  "id": "875a8a65-d05b-4bb6-843a-e1b89a5dd525",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6882860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 363,
        "selector": "L363-L386",
        "symbol": "ProcessJSONLHSMixin._process_as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "30a6d1d3-f324-48ce-a86a-8ab871d3b952",
  "subject_name": "django/db/models/fields/json::ProcessJSONLHSMixin._process_as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def _process_as_oracle(self, sql, params, connection, key_transforms=None)"
}
```
