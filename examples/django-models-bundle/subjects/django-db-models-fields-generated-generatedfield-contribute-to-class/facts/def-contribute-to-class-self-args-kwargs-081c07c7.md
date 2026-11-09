# Fact 081c07c7

Store id: 5b04a268-4151-4b8d-b514-025ac463ef10

## Text

```text
def contribute_to_class(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:31:57.6243080+00:00`

## Data

```json
{
  "end_line": 52,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 46,
  "symbol": "GeneratedField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":46,"selector":"L46-L52","symbol":"GeneratedField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 52,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 46,
    "symbol": "GeneratedField.contribute_to_class"
  },
  "id": "5b04a268-4151-4b8d-b514-025ac463ef10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6243080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 46,
        "selector": "L46-L52",
        "symbol": "GeneratedField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "3411e85c-a7df-4936-ac04-1570fa8588bd",
  "subject_name": "django/db/models/fields/generated::GeneratedField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, *args, **kwargs)"
}
```
