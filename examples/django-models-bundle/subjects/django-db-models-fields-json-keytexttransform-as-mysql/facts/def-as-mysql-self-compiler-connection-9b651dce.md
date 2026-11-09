# Fact 9b651dce

Store id: 2fdf9f6e-1e78-422a-86cd-5616424dad8c

## Text

```text
def as_mysql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.7175070+00:00`

## Data

```json
{
  "end_line": 557,
  "entity_kind": "method",
  "parent": "KeyTextTransform",
  "start_line": 545,
  "symbol": "KeyTextTransform.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":545,"selector":"L545-L557","symbol":"KeyTextTransform.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTextTransform.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 557,
    "entity_kind": "method",
    "parent": "KeyTextTransform",
    "start_line": 545,
    "symbol": "KeyTextTransform.as_mysql"
  },
  "id": "2fdf9f6e-1e78-422a-86cd-5616424dad8c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7175070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 545,
        "selector": "L545-L557",
        "symbol": "KeyTextTransform.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "23e33eed-5775-41f1-b7e6-bba9b90e7d53",
  "subject_name": "django/db/models/fields/json::KeyTextTransform.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection)"
}
```
