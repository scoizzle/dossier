# Fact 43300b37

Store id: 55d475cb-1cd7-481e-9737-537b198feb4c

## Text

```text
class MD5(OracleHashMixin, Transform)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.1079230+00:00`

## Data

```json
{
  "end_line": 218,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 216,
  "symbol": "MD5"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":216,"selector":"L216-L218","symbol":"MD5"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::MD5](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 218,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 216,
    "symbol": "MD5"
  },
  "id": "55d475cb-1cd7-481e-9737-537b198feb4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1079230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 216,
        "selector": "L216-L218",
        "symbol": "MD5"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "5dcd7a98-28e1-4170-8a5b-3bfdd487db0a",
  "subject_name": "django/db/models/functions/text::MD5",
  "tags": [
    "entity:class"
  ],
  "text": "class MD5(OracleHashMixin, Transform)"
}
```
