# Fact 4f7224b3

Store id: 623d45d6-4846-4abb-ad82-b448b7885931

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
- posted_at: `2026-11-09T23:44:51.0438080+00:00`

## Data

```json
{
  "end_line": 649,
  "entity_kind": "method",
  "parent": "KeyTransformExact",
  "start_line": 627,
  "symbol": "KeyTransformExact.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":627,"selector":"L627-L649","symbol":"KeyTransformExact.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformExact.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 649,
    "entity_kind": "method",
    "parent": "KeyTransformExact",
    "start_line": 627,
    "symbol": "KeyTransformExact.process_rhs"
  },
  "id": "623d45d6-4846-4abb-ad82-b448b7885931",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0438080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 627,
        "selector": "L627-L649",
        "symbol": "KeyTransformExact.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "6cb94004-a938-4af7-8b88-89845e691e7c",
  "subject_name": "django/db/models/fields/json::KeyTransformExact.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
