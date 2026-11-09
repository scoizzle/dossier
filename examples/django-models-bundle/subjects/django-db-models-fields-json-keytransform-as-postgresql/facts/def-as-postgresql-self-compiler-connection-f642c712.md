# Fact f642c712

Store id: b99d0da7-0c02-4b21-af24-00691588f91e

## Text

```text
def as_postgresql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:51.0250890+00:00`

## Data

```json
{
  "end_line": 533,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 524,
  "symbol": "KeyTransform.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":524,"selector":"L524-L533","symbol":"KeyTransform.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 533,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 524,
    "symbol": "KeyTransform.as_postgresql"
  },
  "id": "b99d0da7-0c02-4b21-af24-00691588f91e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0250890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 524,
        "selector": "L524-L533",
        "symbol": "KeyTransform.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "743dd939-5dfb-466b-9e28-a3fd123edbb0",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection)"
}
```
