# Fact 65097a6c

Store id: c1b07338-6da9-4fe6-bc82-ffa1363e206f

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:31:55.9498970+00:00`

## Data

```json
{
  "end_line": 1668,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1667,
  "symbol": "When.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1667,"selector":"L1667-L1668","symbol":"When.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1668,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1667,
    "symbol": "When.get_source_expressions"
  },
  "id": "c1b07338-6da9-4fe6-bc82-ffa1363e206f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9498970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1667,
        "selector": "L1667-L1668",
        "symbol": "When.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "846cadce-1216-497b-a3a9-21e1255697b1",
  "subject_name": "django/db/models/expressions::When.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
