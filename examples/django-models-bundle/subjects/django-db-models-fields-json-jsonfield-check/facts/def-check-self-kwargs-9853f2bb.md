# Fact 9853f2bb

Store id: b3e71f03-9f1b-4dba-8d25-908f99b9b391

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:57.8339590+00:00`

## Data

```json
{
  "end_line": 52,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 48,
  "symbol": "JSONField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":48,"selector":"L48-L52","symbol":"JSONField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 52,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 48,
    "symbol": "JSONField.check"
  },
  "id": "b3e71f03-9f1b-4dba-8d25-908f99b9b391",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8339590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 48,
        "selector": "L48-L52",
        "symbol": "JSONField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "d56ba146-0487-4a00-b370-0c353a2686b7",
  "subject_name": "django/db/models/fields/json::JSONField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
