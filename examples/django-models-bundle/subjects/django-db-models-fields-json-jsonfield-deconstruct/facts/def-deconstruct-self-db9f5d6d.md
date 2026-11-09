# Fact db9f5d6d

Store id: 5a8a81c3-731b-411f-8274-046c50e3a2c1

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:43.6053400+00:00`

## Data

```json
{
  "end_line": 84,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 78,
  "symbol": "JSONField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":78,"selector":"L78-L84","symbol":"JSONField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 84,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 78,
    "symbol": "JSONField.deconstruct"
  },
  "id": "5a8a81c3-731b-411f-8274-046c50e3a2c1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6053400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 78,
        "selector": "L78-L84",
        "symbol": "JSONField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "ae530427-9a87-4928-8138-4b6524593a3e",
  "subject_name": "django/db/models/fields/json::JSONField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
