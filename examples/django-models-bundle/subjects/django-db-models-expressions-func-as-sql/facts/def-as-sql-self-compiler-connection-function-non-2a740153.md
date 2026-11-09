# Fact 2a740153

Store id: a4d0febd-3774-4b69-a65c-76917dcfb53a

## Text

```text
def as_sql( self, compiler, connection, function=None, template=None, arg_joiner=None, **extra_context, )
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
- posted_at: `2026-11-09T23:31:55.8560130+00:00`

## Data

```json
{
  "end_line": 1134,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1097,
  "symbol": "Func.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1097,"selector":"L1097-L1134","symbol":"Func.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1134,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1097,
    "symbol": "Func.as_sql"
  },
  "id": "a4d0febd-3774-4b69-a65c-76917dcfb53a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8560130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1097,
        "selector": "L1097-L1134",
        "symbol": "Func.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "72dcf9c9-3290-433c-96dc-84a3fed07150",
  "subject_name": "django/db/models/expressions::Func.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql( self, compiler, connection, function=None, template=None, arg_joiner=None, **extra_context, )"
}
```
