# Fact 9ce2276f

Store id: 2eda1ba6-e7b4-43f5-932e-940201de37ca

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
- posted_at: `2026-11-09T23:31:57.3907450+00:00`

## Data

```json
{
  "end_line": 278,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 273,
  "symbol": "FileField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":273,"selector":"L273-L278","symbol":"FileField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 278,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 273,
    "symbol": "FileField.check"
  },
  "id": "2eda1ba6-e7b4-43f5-932e-940201de37ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3907450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 273,
        "selector": "L273-L278",
        "symbol": "FileField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "a487031d-af23-48b9-8ba9-25485433af7c",
  "subject_name": "django/db/models/fields/files::FileField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
