# Fact 43300b37

Store id: 894e1094-1879-4cc1-b9a3-492d6cff593c

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
- posted_at: `2026-11-09T23:32:02.2230520+00:00`

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
  "id": "894e1094-1879-4cc1-b9a3-492d6cff593c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2230520+00:00"
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
  "subject_id": "5876e6bd-41fc-4218-8f75-7c5db0ac7f4d",
  "subject_name": "django/db/models/functions/text::MD5",
  "tags": [
    "entity:class"
  ],
  "text": "class MD5(OracleHashMixin, Transform)"
}
```
