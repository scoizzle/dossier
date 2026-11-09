# Fact 9c91b258

Store id: 44451408-5115-4db2-84b1-5091cd9199ab

## Text

```text
class JSONField(CheckFieldDefaultMixin, Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.9235080+00:00`

## Data

```json
{
  "end_line": 150,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 24,
  "symbol": "JSONField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":24,"selector":"L24-L150","symbol":"JSONField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 150,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 24,
    "symbol": "JSONField"
  },
  "id": "44451408-5115-4db2-84b1-5091cd9199ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9235080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 24,
        "selector": "L24-L150",
        "symbol": "JSONField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "6603f76f-770b-499e-aed0-4dfb699a73f6",
  "subject_name": "django/db/models/fields/json::JSONField",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONField(CheckFieldDefaultMixin, Field)"
}
```
