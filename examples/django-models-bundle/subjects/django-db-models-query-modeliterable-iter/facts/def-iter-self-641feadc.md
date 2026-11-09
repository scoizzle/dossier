# Fact 641feadc

Store id: b32f2cd6-8a53-4953-a87a-3c253d0f7090

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:32:04.2421330+00:00`

## Data

```json
{
  "end_line": 199,
  "entity_kind": "method",
  "parent": "ModelIterable",
  "start_line": 124,
  "symbol": "ModelIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":124,"selector":"L124-L199","symbol":"ModelIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::ModelIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 199,
    "entity_kind": "method",
    "parent": "ModelIterable",
    "start_line": 124,
    "symbol": "ModelIterable.__iter__"
  },
  "id": "b32f2cd6-8a53-4953-a87a-3c253d0f7090",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2421330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 124,
        "selector": "L124-L199",
        "symbol": "ModelIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "191406ca-c3cd-4ba0-ac66-2fce1df1af23",
  "subject_name": "django/db/models/query::ModelIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
