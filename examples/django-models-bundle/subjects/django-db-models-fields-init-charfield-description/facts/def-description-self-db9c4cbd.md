# Fact db9c4cbd

Store id: 9c565c6b-79cc-4a80-9433-272477a65daa

## Text

```text
def description(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.5477270+00:00`

## Data

```json
{
  "end_line": 1258,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1253,
  "symbol": "CharField.description"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1253,"selector":"L1253-L1258","symbol":"CharField.description"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.description](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1258,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1253,
    "symbol": "CharField.description"
  },
  "id": "9c565c6b-79cc-4a80-9433-272477a65daa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5477270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1253,
        "selector": "L1253-L1258",
        "symbol": "CharField.description"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c6006692-615c-45d4-8f08-ffffbcdddf1c",
  "subject_name": "django/db/models/fields/__init__::CharField.description",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def description(self)"
}
```
