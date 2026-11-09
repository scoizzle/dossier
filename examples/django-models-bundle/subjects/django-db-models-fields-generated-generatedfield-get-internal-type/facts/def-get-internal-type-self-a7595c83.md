# Fact a7595c83

Store id: 3be18551-e547-43d6-8e73-651a15aafe81

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
- posted_at: `2026-11-09T22:39:43.4430940+00:00`

## Data

```json
{
  "end_line": 201,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 200,
  "symbol": "GeneratedField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":200,"selector":"L200-L201","symbol":"GeneratedField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 201,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 200,
    "symbol": "GeneratedField.get_internal_type"
  },
  "id": "3be18551-e547-43d6-8e73-651a15aafe81",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4430940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 200,
        "selector": "L200-L201",
        "symbol": "GeneratedField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "e7a933b5-887c-40cf-97f7-1f1acc9e781a",
  "subject_name": "django/db/models/fields/generated::GeneratedField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
