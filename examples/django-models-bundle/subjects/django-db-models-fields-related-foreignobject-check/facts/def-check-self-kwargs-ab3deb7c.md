# Fact ab3deb7c

Store id: 3b2e5c42-bf73-4c9e-a510-6a51a1a9090e

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
- posted_at: `2026-11-09T23:31:58.6680010+00:00`

## Data

```json
{
  "end_line": 618,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 612,
  "symbol": "ForeignObject.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":612,"selector":"L612-L618","symbol":"ForeignObject.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 618,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 612,
    "symbol": "ForeignObject.check"
  },
  "id": "3b2e5c42-bf73-4c9e-a510-6a51a1a9090e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6680010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 612,
        "selector": "L612-L618",
        "symbol": "ForeignObject.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "c2f1da1a-91ba-447e-b3e7-55690c3f3d82",
  "subject_name": "django/db/models/fields/related::ForeignObject.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
