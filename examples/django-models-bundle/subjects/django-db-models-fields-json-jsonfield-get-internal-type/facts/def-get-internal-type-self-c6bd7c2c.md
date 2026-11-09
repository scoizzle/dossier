# Fact c6bd7c2c

Store id: f7d4b5ba-679b-4145-9115-5056c1e36034

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T22:39:43.6097120+00:00`

## Data

```json
{
  "end_line": 99,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 98,
  "symbol": "JSONField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":98,"selector":"L98-L99","symbol":"JSONField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 99,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 98,
    "symbol": "JSONField.get_internal_type"
  },
  "id": "f7d4b5ba-679b-4145-9115-5056c1e36034",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6097120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 98,
        "selector": "L98-L99",
        "symbol": "JSONField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "9ac1bbec-f6f6-403c-bdd2-9f58c34dc453",
  "subject_name": "django/db/models/fields/json::JSONField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
