# Fact 244a4d1f

Store id: 0f600439-8109-4b90-9aef-70043533b26c

## Text

```text
def __call__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.0753760+00:00`

## Data

```json
{
  "end_line": 767,
  "entity_kind": "method",
  "parent": "KeyTransformFactory",
  "start_line": 766,
  "symbol": "KeyTransformFactory.__call__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":766,"selector":"L766-L767","symbol":"KeyTransformFactory.__call__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformFactory.__call__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 767,
    "entity_kind": "method",
    "parent": "KeyTransformFactory",
    "start_line": 766,
    "symbol": "KeyTransformFactory.__call__"
  },
  "id": "0f600439-8109-4b90-9aef-70043533b26c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0753760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 766,
        "selector": "L766-L767",
        "symbol": "KeyTransformFactory.__call__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "090ab467-6b85-4b3f-9c4d-f867652042ff",
  "subject_name": "django/db/models/fields/json::KeyTransformFactory.__call__",
  "tags": [
    "entity:method"
  ],
  "text": "def __call__(self, *args, **kwargs)"
}
```
