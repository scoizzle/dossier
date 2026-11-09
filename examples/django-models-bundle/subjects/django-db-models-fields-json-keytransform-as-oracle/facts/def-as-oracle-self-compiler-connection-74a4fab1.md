# Fact 74a4fab1

Store id: 6edca9a4-7495-48e0-8173-2ff5afff7da3

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
- posted_at: `2026-11-09T22:39:43.7101830+00:00`

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
  "id": "6edca9a4-7495-48e0-8173-2ff5afff7da3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7101830+00:00"
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
  "subject_id": "d15161e4-8e51-4148-90c0-9d6b4430192a",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
