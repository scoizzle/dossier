# Fact d2ee8383

Store id: e8549981-8d2c-4c09-9d5b-e09607146a34

## Text

```text
def _process_as_sqlite(self, sql, params, connection, key_transforms=None)
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
- posted_at: `2026-11-09T23:44:51.0062750+00:00`

## Data

```json
{
  "end_line": 396,
  "entity_kind": "method",
  "parent": "ProcessJSONLHSMixin",
  "start_line": 388,
  "symbol": "ProcessJSONLHSMixin._process_as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":388,"selector":"L388-L396","symbol":"ProcessJSONLHSMixin._process_as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::ProcessJSONLHSMixin._process_as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 396,
    "entity_kind": "method",
    "parent": "ProcessJSONLHSMixin",
    "start_line": 388,
    "symbol": "ProcessJSONLHSMixin._process_as_sqlite"
  },
  "id": "e8549981-8d2c-4c09-9d5b-e09607146a34",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0062750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 388,
        "selector": "L388-L396",
        "symbol": "ProcessJSONLHSMixin._process_as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "6900e1e3-97b0-495a-b9c2-27e26b6314d1",
  "subject_name": "django/db/models/fields/json::ProcessJSONLHSMixin._process_as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def _process_as_sqlite(self, sql, params, connection, key_transforms=None)"
}
```
