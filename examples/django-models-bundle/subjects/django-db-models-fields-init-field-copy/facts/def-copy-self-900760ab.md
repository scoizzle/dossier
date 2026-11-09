# Fact 900760ab

Store id: 2e29f32c-7d2a-4c27-a695-3440da892a20

## Text

```text
def __copy__(self)
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
- posted_at: `2026-11-09T23:31:56.4592320+00:00`

## Data

```json
{
  "end_line": 762,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 756,
  "symbol": "Field.__copy__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":756,"selector":"L756-L762","symbol":"Field.__copy__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__copy__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 762,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 756,
    "symbol": "Field.__copy__"
  },
  "id": "2e29f32c-7d2a-4c27-a695-3440da892a20",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4592320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 756,
        "selector": "L756-L762",
        "symbol": "Field.__copy__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "735a5a2f-95c8-425f-b5a6-46ac8e9f0a2e",
  "subject_name": "django/db/models/fields/__init__::Field.__copy__",
  "tags": [
    "entity:method"
  ],
  "text": "def __copy__(self)"
}
```
