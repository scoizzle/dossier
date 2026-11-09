# Fact e8a0a2b4

Store id: 1f01794c-2e24-4086-9a3a-652c18171319

## Text

```text
def validate(self, value, model_instance)
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
- posted_at: `2026-11-09T22:39:43.6189040+00:00`

## Data

```json
{
  "end_line": 137,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 128,
  "symbol": "JSONField.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":128,"selector":"L128-L137","symbol":"JSONField.validate"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 137,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 128,
    "symbol": "JSONField.validate"
  },
  "id": "1f01794c-2e24-4086-9a3a-652c18171319",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6189040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 128,
        "selector": "L128-L137",
        "symbol": "JSONField.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "2dd62607-3b93-49c3-8545-f67663980f7b",
  "subject_name": "django/db/models/fields/json::JSONField.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```
