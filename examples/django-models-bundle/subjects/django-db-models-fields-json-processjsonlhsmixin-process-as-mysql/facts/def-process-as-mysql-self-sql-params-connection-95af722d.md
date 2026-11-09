# Fact 95af722d

Store id: e7aadbb6-a742-492b-848f-e282dc1eaa6c

## Text

```text
def _process_as_mysql(self, sql, params, connection, key_transforms=None)
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
- posted_at: `2026-11-09T23:44:51.0082850+00:00`

## Data

```json
{
  "end_line": 400,
  "entity_kind": "method",
  "parent": "ProcessJSONLHSMixin",
  "start_line": 398,
  "symbol": "ProcessJSONLHSMixin._process_as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":398,"selector":"L398-L400","symbol":"ProcessJSONLHSMixin._process_as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::ProcessJSONLHSMixin._process_as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 400,
    "entity_kind": "method",
    "parent": "ProcessJSONLHSMixin",
    "start_line": 398,
    "symbol": "ProcessJSONLHSMixin._process_as_mysql"
  },
  "id": "e7aadbb6-a742-492b-848f-e282dc1eaa6c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0082850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 398,
        "selector": "L398-L400",
        "symbol": "ProcessJSONLHSMixin._process_as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "2a48ecb3-9033-40a8-a44a-68aaa9432158",
  "subject_name": "django/db/models/fields/json::ProcessJSONLHSMixin._process_as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def _process_as_mysql(self, sql, params, connection, key_transforms=None)"
}
```
