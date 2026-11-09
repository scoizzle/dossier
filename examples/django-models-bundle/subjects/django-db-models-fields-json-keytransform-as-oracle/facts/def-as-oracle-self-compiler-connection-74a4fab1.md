# Fact 74a4fab1

Store id: a706bfa6-b709-4060-8848-529a329d4c5a

## Text

```text
def as_oracle(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.9699460+00:00`

## Data

```json
{
  "end_line": 522,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 520,
  "symbol": "KeyTransform.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":520,"selector":"L520-L522","symbol":"KeyTransform.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 522,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 520,
    "symbol": "KeyTransform.as_oracle"
  },
  "id": "a706bfa6-b709-4060-8848-529a329d4c5a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9699460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 520,
        "selector": "L520-L522",
        "symbol": "KeyTransform.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "0daddc1f-4117-47cb-9fa0-091fc2059250",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
