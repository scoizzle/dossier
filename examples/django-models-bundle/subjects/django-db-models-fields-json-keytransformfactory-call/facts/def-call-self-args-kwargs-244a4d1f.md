# Fact 244a4d1f

Store id: 53081d26-b723-4a3b-9e78-de0ead71bb03

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
- posted_at: `2026-11-09T23:31:58.0458720+00:00`

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
  "id": "53081d26-b723-4a3b-9e78-de0ead71bb03",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0458720+00:00"
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
  "subject_id": "8adcd17a-adca-4505-8714-a205e0a4909e",
  "subject_name": "django/db/models/fields/json::KeyTransformFactory.__call__",
  "tags": [
    "entity:method"
  ],
  "text": "def __call__(self, *args, **kwargs)"
}
```
