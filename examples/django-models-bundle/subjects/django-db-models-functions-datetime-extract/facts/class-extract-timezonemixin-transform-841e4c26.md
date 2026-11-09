# Fact 841e4c26

Store id: a9e09180-fceb-4799-be01-a30193019011

## Text

```text
class Extract(TimezoneMixin, Transform)
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
- posted_at: `2026-11-09T23:44:53.3186300+00:00`

## Data

```json
{
  "end_line": 121,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 39,
  "symbol": "Extract"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":39,"selector":"L39-L121","symbol":"Extract"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Extract](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 121,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 39,
    "symbol": "Extract"
  },
  "id": "a9e09180-fceb-4799-be01-a30193019011",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3186300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 39,
        "selector": "L39-L121",
        "symbol": "Extract"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "e44fd605-bc56-41e4-a8c2-492fb5d0f1f0",
  "subject_name": "django/db/models/functions/datetime::Extract",
  "tags": [
    "entity:class"
  ],
  "text": "class Extract(TimezoneMixin, Transform)"
}
```
