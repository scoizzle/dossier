# Fact 4ca0c630

Store id: be853066-3006-407c-b567-20f0db8b7791

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:58.0306920+00:00`

## Data

```json
{
  "end_line": 725,
  "entity_kind": "method",
  "parent": "KeyTransformNumericLookupMixin",
  "start_line": 721,
  "symbol": "KeyTransformNumericLookupMixin.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":721,"selector":"L721-L725","symbol":"KeyTransformNumericLookupMixin.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformNumericLookupMixin.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 725,
    "entity_kind": "method",
    "parent": "KeyTransformNumericLookupMixin",
    "start_line": 721,
    "symbol": "KeyTransformNumericLookupMixin.process_rhs"
  },
  "id": "be853066-3006-407c-b567-20f0db8b7791",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0306920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 721,
        "selector": "L721-L725",
        "symbol": "KeyTransformNumericLookupMixin.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "be681674-a9f5-43f6-b6d5-1d7c10fc5c83",
  "subject_name": "django/db/models/fields/json::KeyTransformNumericLookupMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
