# Fact ab3deb7c

Store id: 777f657a-cce1-4dff-8c23-9c0fca86dbd5

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
- posted_at: `2026-11-09T22:39:44.3132920+00:00`

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
  "id": "777f657a-cce1-4dff-8c23-9c0fca86dbd5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3132920+00:00"
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
  "subject_id": "117f42d6-8c0e-4b09-8801-e0dddf3d92c8",
  "subject_name": "django/db/models/fields/related::ForeignObject.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
