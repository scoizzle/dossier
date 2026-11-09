# Fact 27f873c2

Store id: 57ddfa70-965f-4bc2-b23a-35f1e2447498

## Text

```text
def _set_pk_val(self, value)
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
- posted_at: `2026-11-09T23:44:48.5296820+00:00`

## Data

```json
{
  "end_line": 706,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 702,
  "symbol": "Model._set_pk_val"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":702,"selector":"L702-L706","symbol":"Model._set_pk_val"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._set_pk_val](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 706,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 702,
    "symbol": "Model._set_pk_val"
  },
  "id": "57ddfa70-965f-4bc2-b23a-35f1e2447498",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5296820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 702,
        "selector": "L702-L706",
        "symbol": "Model._set_pk_val"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "cb0859ac-ff81-47d7-ad6f-31789edb1a71",
  "subject_name": "django/db/models/base::Model._set_pk_val",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_pk_val(self, value)"
}
```
