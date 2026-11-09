# Fact b5d4f81e

Store id: fac02254-3efb-4cb2-850e-0b36963d1b3e

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
- posted_at: `2026-11-09T23:31:57.9383360+00:00`

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
  "id": "fac02254-3efb-4cb2-850e-0b36963d1b3e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9383360+00:00"
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
  "subject_id": "d8b58d72-a614-4b40-abde-dff656c555a0",
  "subject_name": "django/db/models/fields/json::ProcessJSONLHSMixin._process_as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def _process_as_oracle(self, sql, params, connection, key_transforms=None)"
}
```
